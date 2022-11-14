import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Solicitudes } from 'src/app/models/Solicitudes.model';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { SolicitudesService } from 'src/app/services/solicitudes/solicitudes.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-solicitudes',
  templateUrl: './solicitudes.component.html',
  styleUrls: ['./solicitudes.component.scss']
})
export class SolicitudesComponent implements OnInit {

  obj:Solicitudes;
  User=this.srvAuth.currentUserValue.Nombre;

  constructor(private srvObj:SolicitudesService,private srvAuth:AuthenticationService, srvShared:SharedService,private route:Router) {
        this.obj=new Solicitudes();
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