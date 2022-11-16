import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Categorias } from 'src/app/models/Categorias.model';
import { SolicitudesDetalle } from 'src/app/models/SolcitudesDetalle.model';
import { Solicitudes } from 'src/app/models/Solicitudes.model';
import { SolicitudesUsuario } from 'src/app/models/SolicitudesUsuarios.model';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import { CategoriasService } from 'src/app/services/categorias/categorias.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { SolicitudesService } from 'src/app/services/solicitudes/solicitudes.service';
import Swal from 'sweetalert2';
import { DetalleGeneralFormComponent } from '../../shared/detalle-general-form/detalle-general-form.component';
import { ItinerarioFormComponent } from '../../shared/itinerario-form/itinerario-form.component';
import { ReservaAlquilerAutoFormComponent } from '../../shared/reserva-alquiler-auto-form/reserva-alquiler-auto-form.component';
import { ReservaHotelFormComponent } from '../../shared/reserva-hotel-form/reserva-hotel-form.component';
import { ReservasAereoFormComponent } from '../../shared/reservas-aereo-form/reservas-aereo-form.component';
import { SolicitudesUsuarioFormComponent } from '../../shared/solicitudes-usuario-form/solicitudes-usuario-form.component';

@Component({
  selector: 'app-solicitudes',
  templateUrl: './solicitudes.component.html',
  styleUrls: ['./solicitudes.component.scss']
})
export class SolicitudesComponent implements OnInit {

  obj:Solicitudes=new Solicitudes();
  User=this.srvAuth.currentUserValue.Nombre;
  idCategoria:number;
  Categorias:Categorias[]=[];
  constructor(private srvObj:SolicitudesService,private srvAuth:AuthenticationService, private srvShared:SharedService,private route:Router,private modal:NgbModal,private srvCategorias:CategoriasService) {
    this.srvCategorias.todas().subscribe((lc)=>{
      this.Categorias=lc;
      this.obj=new Solicitudes();
    })
    
  }
 
  NuevaSolUsu(){
    this.srvShared.objModal=null;
    this.modal.open(SolicitudesUsuarioFormComponent, { size: 'md' }).result.then((result) => {
        if(result!=null){
          this.obj.SolcitudesUsuarios.push(result);
        }
      }, (reason)=>{ 

      }
    );
  }
  NuevoDetalle(){
    this.srvShared.objModal=null;
    let compo:any;
    
    switch(this.idCategoria){
      case 1:
        compo=ReservasAereoFormComponent;
        break;
      case 2:
        compo=ReservaAlquilerAutoFormComponent;
        break;
      case 3:
        compo=ReservaHotelFormComponent;
        break;
      case 4:
        compo=ItinerarioFormComponent;
        break;
      default:
        compo:DetalleGeneralFormComponent;
        break;
    }
    


    this.modal.open(compo, { size: 'lg' }).result.then((result) => {
        if(result!=null){
          this.obj.Detalle.push(result);
        }
      }, (reason)=>{ 

      }
    );
  }

  BorrarDetalle(det:SolicitudesDetalle){

  }
  BorrarSolUsu(solusu:SolicitudesUsuario){
    let index=this.obj.SolcitudesUsuarios.findIndex(su=>su.IdSolicitudUsuario==solusu.IdSolicitudUsuario)
    if(index>=0){
      this.obj.SolcitudesUsuarios.splice(index,1);
    }
  }

  getDetalle(det:SolicitudesDetalle){
    let ret:string="";
    if(det.ReservasAlquilerAutoEntity!=null){
      ret=`Reserva de alquiler de auto en ${det.ReservasAlquilerAutoEntity.UbicacionesEntity.Nombre} para el ${det.ReservasAlquilerAutoEntity.FechaDesde} al ${det.ReservasAlquilerAutoEntity.FechaHasta} para ${det.ReservasAlquilerAutoEntity.CantPasajeros} pasajeros`
    }
    return ret;
  }
  Guardar(){
    this.obj.IdUsuario=this.srvAuth.currentUserValue.IdUsuario;
    this.srvObj.AgregarEditar(this.obj,this.obj.IdSolicitud).subscribe((band)=>{
      if(band){

        Swal.fire("Ok","La solicitud se realizó con éxito",'success');
        this.route.navigate(['admin/solicitudes'])
      }
    },(err)=>{
      Swal.fire("Upps",err.error.Message,'warning');
    })
  }
  

  ngOnInit(): void {
  }

}