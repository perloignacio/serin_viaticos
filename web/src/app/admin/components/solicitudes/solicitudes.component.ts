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
  agregar:boolean=true;
  constructor(private srvObj:SolicitudesService,private srvAuth:AuthenticationService, private srvShared:SharedService,private route:Router,private modal:NgbModal,private srvCategorias:CategoriasService) {
    this.srvCategorias.todas().subscribe((lc)=>{
      this.Categorias=lc;
      this.obj=this.srvShared.ObjEdit as Solicitudes;
      if(this.obj==null){
        this.obj=new Solicitudes();
      }else{
        this.agregar=false;
      }
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
  NuevoDetalle(tmp:SolicitudesDetalle){
    this.srvShared.objModal=null;
    let compo:any=DetalleGeneralFormComponent;
    let tmpObj:any;
    if(tmp!=null){
      this.idCategoria=tmp.IdSolicitudCategoria;
    }
    switch(this.idCategoria){
      case 1:
        compo=ReservasAereoFormComponent;
        if(tmp!=null){
          tmpObj=tmp.ReservasAereosEntity;
        }
        break;
      case 2:
        compo=ReservaAlquilerAutoFormComponent;
        if(tmp!=null){
          tmpObj=tmp.ReservasAlquilerAutoEntity;
        }

        break;
      case 3:
        compo=ReservaHotelFormComponent;
        if(tmp!=null){
          tmpObj=tmp.ReservasHotelEntity;
        }
        break;
      case 4:
        compo=ItinerarioFormComponent;
        if(tmp!=null){
          tmpObj=tmp.ItinerarioEntity;
        }
        break;
      default:
        if(tmp!=null){
          tmpObj=tmp;
        }
        break;
    }
    
    if(tmpObj!=null){
      this.srvShared.objModal=tmpObj;
    }
    this.modal.open(compo, { size: 'lg' }).result.then((result) => {
        if(result!=null){
          result.IdSolicitudCategoria=this.idCategoria;
          this.obj.Detalle.push(result);
        }
      }, (reason)=>{ 

      }
    );
  }

  BorrarDetalle(det:SolicitudesDetalle){
    let index=this.obj.Detalle.findIndex(d=>d.IdSolicitudDetalle==det.IdSolicitudDetalle);
    if(index!=-1){
      this.obj.Detalle.splice(index,1);
    }
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
      ret=`Reserva de alquiler de auto en ${det.ReservasAlquilerAutoEntity.UbicacionesEntity.Nombre} para el ${det.ReservasAlquilerAutoEntity.FechaDesde} al ${det.ReservasAlquilerAutoEntity.FechaHasta} para ${det.ReservasAlquilerAutoEntity.CantPasajeros} pasajero/s.`
    }else{
      if(det.ReservasAereosEntity!=null){
        ret=`Reserva de aéreo para el ${det.ReservasAereosEntity.FechaViaje} con salida desde ${det.ReservasAereosEntity.UbicacionesOrigenEntity.Nombre} hacia ${det.ReservasAereosEntity.UbicacionesDestinoEntity.Nombre} para ${det.ReservasAereosEntity.CantPasajeros} pasajero/s.`
      }else{
        if(det.ReservasHotelEntity!=null){
          ret=`Reserva de ${det.ReservasHotelEntity.CantHabitaciones} habitacion/es para ${det.ReservasHotelEntity.CantPasajeros} pasajero/s, en ${det.ReservasHotelEntity.HotelesEntity.Nombre} en ${det.ReservasHotelEntity.UbicacionesEntity.Nombre}, desde el ${det.ReservasHotelEntity.Checkin} al ${det.ReservasHotelEntity.Checkout}.`
        }else{
          if(det.ItinerarioEntity!=null){
            ret=`Viaje para el dia ${det.ItinerarioEntity.Fecha} Salida desde ${det.ItinerarioEntity.Detalle[0].UbicacionesEntity.Nombre} con destino final ${det.ItinerarioEntity.Detalle[det.ItinerarioEntity.Detalle.length-1].UbicacionesEntity.Nombre}`
          }else{
            ret=det.Observaciones;
          }
        }
    
      }
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