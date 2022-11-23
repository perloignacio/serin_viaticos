import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Hoteles } from 'src/app/models/Hoteles.model';
import { ReservasHotel } from 'src/app/models/ReservasHotel.model';
import { SolicitudesDetalle } from 'src/app/models/SolcitudesDetalle.model';
import { Ubicaciones } from 'src/app/models/Ubicaciones.model';
import { HotelesService } from 'src/app/services/hoteles/hoteles.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { UbicacionesService } from 'src/app/services/ubicaciones/ubicaciones.service';

@Component({
  selector: 'app-reserva-hotel-form',
  templateUrl: './reserva-hotel-form.component.html',
  styleUrls: ['./reserva-hotel-form.component.scss']
})
export class ReservaHotelFormComponent implements OnInit {

  obj:ReservasHotel=new ReservasHotel();
  ubicaciones:Ubicaciones[]=[];
  hoteles:Hoteles[]=[];
  agregar:boolean=true;
  detalle:SolicitudesDetalle=new SolicitudesDetalle();
  Observaciones:string;
  
  constructor(private modal:NgbActiveModal,private srvHoteles:HotelesService,private srvUbicaciones:UbicacionesService,private srvShared:SharedService) { 
    this.srvUbicaciones.todas().subscribe((lu)=>{
      this.ubicaciones=lu;
      this.srvHoteles.todos().subscribe((lh)=>{
        this.hoteles=lh;
        if(this.srvShared.objModal as ReservasHotel!=null){
          this.agregar=false;
          this.obj=this.srvShared.objModal as ReservasHotel;
        }else{
          this.obj=new ReservasHotel();
        }  
      })
      
      
    })
  }

  Guardar(){
    
    if(this.agregar){
      this.detalle.IdSolicitudDetalle=Math.floor(Math.random() * 10000000);
    }
    this.detalle.ReservasHotelEntity=this.obj;
    this.detalle.ReservasHotelEntity.HotelesEntity=this.hoteles.find(ub=>ub.IdHotel==this.obj.IdHotel);
    this.detalle.ReservasHotelEntity.UbicacionesEntity=this.ubicaciones.find(ub=>ub.IdUbicacion==this.obj.IdDestino);
    this.detalle.Observaciones=this.Observaciones;
    this.modal.close(this.detalle);
  }


  cerrar(){
    this.modal.close();
  }

  ngOnInit(): void {
  }

}
