import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Hoteles } from 'src/app/models/Hoteles.model';
import { Ubicaciones } from 'src/app/models/Ubicaciones.model';
import { HotelesService } from 'src/app/services/hoteles/hoteles.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { UbicacionesService } from 'src/app/services/ubicaciones/ubicaciones.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-hoteles-form',
  templateUrl: './hoteles-form.component.html',
  styleUrls: ['./hoteles-form.component.scss']
})
export class HotelesFormComponent implements OnInit {

  Agregar:boolean=true;
  obj:Hoteles;
  ubicaciones:Ubicaciones[]=[];
  constructor(private srvObj:HotelesService,private srvShared:SharedService,private route:Router,private srvUbicaciones:UbicacionesService) {
    this.srvUbicaciones.todas().subscribe((lu)=>{
      this.ubicaciones=lu;
      this.obj=this.srvShared.ObjEdit as Hoteles;
      if(this.obj!=null){
        this.Agregar=false;
      }else{
        this.obj=new Hoteles();
      }
    })
      
   }

   Guardar(){
    
    this.srvObj.AgregarEditar(this.obj,this.obj.IdHotel).subscribe((band)=>{
      if(band){

        Swal.fire("Ok","La operación se realizó con éxito",'success');
        this.route.navigate(['admin/hoteles'])
      }
    },(err)=>{
      Swal.fire("Upps",err.error.Message,'warning');
    })
  }
  
   Volver(){
    history.back();
  }

  ngOnInit(): void {
  }
} 
