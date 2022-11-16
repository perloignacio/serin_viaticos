import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { ReservasAlquilerAuto } from 'src/app/models/ReservasAlquilerAuto.model';
import { SolicitudesDetalle } from 'src/app/models/SolcitudesDetalle.model';
import { Ubicaciones } from 'src/app/models/Ubicaciones.model';
import { SharedService } from 'src/app/services/shared/shared.service';
import { UbicacionesService } from 'src/app/services/ubicaciones/ubicaciones.service';

@Component({
  selector: 'app-reserva-alquiler-auto-form',
  templateUrl: './reserva-alquiler-auto-form.component.html',
  styleUrls: ['./reserva-alquiler-auto-form.component.scss']
})
export class ReservaAlquilerAutoFormComponent implements OnInit {
  obj:ReservasAlquilerAuto=new ReservasAlquilerAuto();
  ubicaciones:Ubicaciones[]=[];
  agregar:boolean=true;
  detalle:SolicitudesDetalle=new SolicitudesDetalle();
  Observaciones:string;
  constructor(private srvUbicaciones:UbicacionesService,private srvShared:SharedService,private modal:NgbActiveModal) { 
    this.srvUbicaciones.todas().subscribe((lu)=>{
      this.ubicaciones=lu;
      if(this.srvShared.objModal as ReservasAlquilerAuto!=null){
        this.agregar=false;
        this.obj=this.srvShared.objModal as ReservasAlquilerAuto;
      }else{
        this.obj=new ReservasAlquilerAuto();
      }
    })
  }

  Guardar(){
    
    if(this.agregar){
      this.detalle.IdSolicitudDetalle=Math.floor(Math.random() * 10000000);
    }
    this.detalle.ReservasAlquilerAutoEntity=this.obj;
    this.detalle.ReservasAlquilerAutoEntity.UbicacionesEntity=this.ubicaciones.find(ub=>ub.IdUbicacion==this.obj.IdDestino);
    this.detalle.Observaciones=this.Observaciones;
    this.modal.close(this.detalle);
  }

  ngOnInit(): void {
  }
  cerrar(){
    this.modal.close();
  }

}
