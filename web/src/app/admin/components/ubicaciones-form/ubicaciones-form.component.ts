import { MapsAPILoader } from '@agm/core';
import { Component, ElementRef, NgZone, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { Ubicaciones } from 'src/app/models/Ubicaciones.model';
import { SharedService } from 'src/app/services/shared/shared.service';
import { UbicacionesService } from 'src/app/services/ubicaciones/ubicaciones.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-ubicaciones-form',
  templateUrl: './ubicaciones-form.component.html',
  styleUrls: ['./ubicaciones-form.component.scss']
})
export class UbicacionesFormComponent implements OnInit {

  obj:Ubicaciones=new Ubicaciones();
  latitude: number=-31.4200833;
  longitude: number=-64.1887761;
  zoom: number=11;
  address: string;
  geolocalizado:boolean=false;
  private geoCoder:any;
  @ViewChild('search')
  public searchElementRef: ElementRef;
  constructor(private srvUbicaciones:UbicacionesService,private mapsAPILoader: MapsAPILoader, private ngZone: NgZone,private route:Router,private srvShared:SharedService) {
    this.obj=this.srvShared.ObjEdit as Ubicaciones;
      if(this.obj==null){
        this.obj=new Ubicaciones();
      }else{
        this.latitude=this.obj.Lat;
        this.longitude=this.obj.Lng;
      }
   
  }

  
  Volver(){
    history.back();
  }
  

  ngAfterViewInit():void{
    this.mapsAPILoader.load().then(() => {
      //this.setCurrentLocation();
      this.geoCoder = new google.maps.Geocoder;
      
      this.getAddress(this.latitude, this.longitude);
      this.mapsAPILoader.load().then(() => {
        let autocomplete = new google.maps.places.Autocomplete(this.searchElementRef.nativeElement);
        autocomplete.addListener("place_changed", () => {
          this.ngZone.run(() => {
            // some details
            let place: google.maps.places.PlaceResult = autocomplete.getPlace();
            this.address = place.formatted_address;
            
            //set latitude, longitude and zoom
            this.latitude = place.geometry.location.lat();
            this.longitude = place.geometry.location.lng();
            this.zoom = 12;
          });
        });
      });
      
      
    });
  }

  
  markerDragEnd($event: any) {
    this.latitude = $event.latLng.lat();
    this.longitude = $event.latLng.lng();
    this.getAddress(this.latitude, this.longitude);
  }

  getAddress(latitude:any, longitude:any) {
    this.geoCoder.geocode({ 'location': { lat: latitude, lng: longitude } }, (results:any, status:any) => {
      if (status === 'OK') {
        if (results[0]) {
          this.zoom = 12;
          this.address = results[0].formatted_address;
        } else {
          window.alert('No results found');
        }
      } else {
        window.alert('Geocoder failed due to: ' + status);
      }
  
    });
  }
  ngOnInit(): void {
  }
  Guardar(){
    this.obj.Lat=this.latitude;
    this.obj.Lng=this.longitude;
    this.obj.Nombre=this.searchElementRef.nativeElement.value;
    this.srvUbicaciones.AgregarEditar(this.obj,this.obj.IdUbicacion).subscribe((band)=>{
      if(band){

        Swal.fire("Ok","La operación se realizó con éxito",'success');
        this.route.navigate(['admin/ubicaciones'])
      }
    },(err)=>{
      Swal.fire("Upps",err.error.Message,'warning');
    })
    
  }
  

}
