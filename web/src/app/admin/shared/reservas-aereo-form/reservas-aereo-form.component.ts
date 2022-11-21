import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { ReservasAereos } from 'src/app/models/ReservasAereo.model';
import { SolicitudesDetalle } from 'src/app/models/SolcitudesDetalle.model';
import { Ubicaciones } from 'src/app/models/Ubicaciones.model';
import { SharedService } from 'src/app/services/shared/shared.service';
import { UbicacionesService } from 'src/app/services/ubicaciones/ubicaciones.service';

@Component({
  selector: 'app-reservas-aereo-form',
  templateUrl: './reservas-aereo-form.component.html',
  styleUrls: ['./reservas-aereo-form.component.scss']
})
export class ReservasAereoFormComponent implements OnInit {

  obj:ReservasAereos=new ReservasAereos();
  ubicaciones:Ubicaciones[]=[];
  agregar:boolean=true;
  detalle:SolicitudesDetalle=new SolicitudesDetalle();
  Observaciones:string;
  
  constructor(private srvUbicaciones:UbicacionesService,private srvShared:SharedService,private modal:NgbActiveModal) { 
    this.srvUbicaciones.todas().subscribe((lu)=>{
      this.ubicaciones=lu;
      if(this.srvShared.objModal as ReservasAereos!=null){
        this.agregar=false;
        this.obj=this.srvShared.objModal as ReservasAereos;
      }else{
        this.obj=new ReservasAereos();
      }
    })
  }

  Guardar(){
    
    if(this.agregar){
      this.detalle.IdSolicitudDetalle=Math.floor(Math.random() * 10000000);
    }
    this.detalle.ReservasAereosEntity=this.obj;
    this.detalle.ReservasAereosEntity.UbicacionesOrigenEntity=this.ubicaciones.find(ub=>ub.IdUbicacion==this.obj.IdOrigen);
    this.detalle.ReservasAereosEntity.UbicacionesDestinoEntity=this.ubicaciones.find(ub=>ub.IdUbicacion==this.obj.IdDestino);
    this.detalle.Observaciones=this.Observaciones;
    this.modal.close(this.detalle);
  }

  ngOnInit(): void {
  }
  
  cerrar(){
    this.modal.close();
  }

}

