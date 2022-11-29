import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { SolicitudesDetalle } from 'src/app/models/SolcitudesDetalle.model';
import { SharedService } from 'src/app/services/shared/shared.service';

@Component({
  selector: 'app-detalle-general-form',
  templateUrl: './detalle-general-form.component.html',
  styleUrls: ['./detalle-general-form.component.scss']
})
export class DetalleGeneralFormComponent implements OnInit {
  agregar:boolean=true;
  detalle:SolicitudesDetalle=new SolicitudesDetalle();
  Observaciones:string;
  
  constructor(private modal:NgbActiveModal,private srvShared:SharedService) {
    console.log(this.srvShared.objModal);
    if(this.srvShared.objModal as SolicitudesDetalle!=null){
      this.detalle=this.srvShared.objModal as SolicitudesDetalle
      this.Observaciones=this.detalle.Observaciones;
      this.agregar=false;
    }
   }

  ngOnInit(): void {
  }

  Guardar(){
    if(this.agregar){
      this.detalle.IdSolicitudDetalle=Math.floor(Math.random() * 10000000);
    }
    this.detalle.Observaciones=this.Observaciones;
    this.modal.close(this.detalle);
  }

  cerrar(){
    this.modal.close();
  }

}
