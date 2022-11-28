import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { MapsAPILoader } from '@agm/core';
import { ItinerarioDetalle } from 'src/app/models/ItinerarioDetalle.model';
import { Itinerario } from 'src/app/models/Itinerario.model';
import { Ubicaciones } from 'src/app/models/Ubicaciones.model';
import { UbicacionesService } from 'src/app/services/ubicaciones/ubicaciones.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { SolicitudesDetalle } from 'src/app/models/SolcitudesDetalle.model';
import Swal from 'sweetalert2';


@Component({
  selector: 'app-itinerario-form',
  templateUrl: './itinerario-form.component.html',
  styleUrls: ['./itinerario-form.component.scss']
})

export class ItinerarioFormComponent implements OnInit {
  dir = undefined;
  latitude: number=-31.4200833;
  longitude: number=-64.1887761;
  zoom: number=11;
  Observaciones:string="";
  waypoints:any[]=[];
  Detalle:ItinerarioDetalle[]=[];
  obj:Itinerario=new Itinerario();
  ubicaciones:Ubicaciones[]=[];
  agregar:boolean=true;
  IdParada:number;
  DetalleSolicitud:SolicitudesDetalle=new SolicitudesDetalle();
 
  constructor(private modal:NgbActiveModal,private srvUbicaciones:UbicacionesService,private srvShared:SharedService) {
    
  }
  AgregarParada(){
    let parada:Ubicaciones;
    parada=this.ubicaciones.find(u=>u.IdUbicacion==this.IdParada);
    if(parada){
      let id:ItinerarioDetalle=new ItinerarioDetalle();
      id.IdParada=this.IdParada;
      id.UbicacionesEntity=parada;
      this.Detalle.push(id);
      this.Dibujar();
    }
    
    
      
  }

  borrarParada(det:ItinerarioDetalle){
    let index=this.Detalle.findIndex(d=>d.UbicacionesEntity.IdUbicacion==det.UbicacionesEntity.IdUbicacion);
    if(index!=-1){
      this.Detalle.splice(index,1);
      this.Dibujar();
      this.Distancia()
    }
  }
  Dibujar(){
    this.dir=undefined;
    this.waypoints=[];
    if(this.Detalle.length>=2){
      this.dir = 
      {
        origin: { lat: this.Detalle[0].UbicacionesEntity.Lat, lng: this.Detalle[0].UbicacionesEntity.Lng },
        destination: { lat: this.Detalle[this.Detalle.length-1].UbicacionesEntity.Lat, lng: this.Detalle[this.Detalle.length-1].UbicacionesEntity.Lng }
      }
    }
   
    if(this.Detalle.length>=3){
      for(let i=1;i<=this.Detalle.length-2;i++){
        this.waypoints.push({location: { lat: this.Detalle[i].UbicacionesEntity.Lat, lng: this.Detalle[i].UbicacionesEntity.Lng }});
      }
    }
    if(this.agregar){
      this.Distancia()
    }
    
     
    
  }
  Distancia(){
    this.obj.Km=0;
    for(let i=0;i<=this.Detalle.length-1;i++){
      if(this.Detalle[i+1]){
        let from:google.maps.LatLng=new google.maps.LatLng(this.Detalle[i].UbicacionesEntity.Lat,this.Detalle[i].UbicacionesEntity.Lng);
        let to:google.maps.LatLng=new google.maps.LatLng(this.Detalle[i+1].UbicacionesEntity.Lat,this.Detalle[i+1].UbicacionesEntity.Lng);

       this.obj.Km+= google.maps.geometry.spherical.computeDistanceBetween(from, to);
       
      }
      
    }
    this.obj.Km=this.obj.Km/1000;
    
      
  }
  Guardar(){
    if(this.validar()){
      if(this.agregar){
        this.DetalleSolicitud.IdSolicitudDetalle=Math.floor(Math.random() * 10000000);
      }
      this.obj.Detalle=this.Detalle;
      this.DetalleSolicitud.ItinerarioEntity=this.obj;
      
      this.DetalleSolicitud.Observaciones=this.Observaciones;
      this.modal.close(this.DetalleSolicitud);
    }
    
  }
  validar():boolean{
    if(this.Detalle.length==0 || this.Detalle.length<2){
      Swal.fire("Upps", "Debe indicar al menos 2 paradas",'info');
      return false;
    }
    return true;
  }
  ngOnInit(): void {
    this.srvUbicaciones.todas().subscribe((lu)=>{
      this.ubicaciones=lu;
      if(this.srvShared.objModal as Itinerario!=null){
        this.agregar=false;
        let tmp=this.srvShared.objModal as Itinerario;

        this.obj.Detalle=tmp.Detalle;
        this.obj.Fecha=tmp.Fecha;
        this.obj.FechaVuelta=tmp.FechaVuelta;
        this.obj.IdItinerario=tmp.IdItinerario;
        this.obj.IdaVuelta=tmp.IdaVuelta;
        this.obj.Km=tmp.Km;
        this.Detalle=tmp.Detalle;
        
        this.Dibujar();
      }else{
        this.obj=new Itinerario();
      }
    })
  }
  cerrar(){
    this.modal.close();
  }

}



