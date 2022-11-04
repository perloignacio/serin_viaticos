import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Usuario } from 'src/app/models/Usuario.model';
import { UsuariosDependencia } from 'src/app/models/UsuariosDependencia.model';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { UsuariosDependenciaService } from 'src/app/services/usuariosDependencia/usuarios-dependencia.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-usuarios-dependencia-form',
  templateUrl: './usuarios-dependencia-form.component.html',
  styleUrls: ['./usuarios-dependencia-form.component.scss']
})
export class UsuariosDependenciaFormComponent implements OnInit {
  Agregar:boolean=true;
  obj:UsuariosDependencia=new UsuariosDependencia();
  usuarios:Usuario[]=[]
  constructor(private srvObj:UsuariosDependenciaService,private srvShared:SharedService,private route:Router,private srvAuth:AuthenticationService) {
    this.srvAuth.todos().subscribe((lu)=>{
      this.usuarios=lu;
      this.obj=this.srvShared.ObjEdit as UsuariosDependencia;
      if(this.obj!=null){
        this.Agregar=false;
      }else{
        this.obj=new UsuariosDependencia();
      }
    })
      
   }

   Guardar(){
    this.srvObj.AgregarEditar(this.obj,this.obj.IdUsuarioDependencia).subscribe((band)=>{
      if(band){

        Swal.fire("Ok","La operación se realizó con éxito",'success');
        this.route.navigate(['admin/usuariosDependencia'])
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