import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UsuariosDependencia } from 'src/app/models/UsuariosDependencia.model';
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
  obj:UsuariosDependencia;

  constructor(private srvObj:UsuariosDependenciaService,private srvShared:SharedService,private route:Router) {
    this.obj=this.srvShared.ObjEdit as UsuariosDependencia;
      if(this.obj!=null){
        this.Agregar=false;
      }else{
        this.obj=new UsuariosDependencia();
      }
   }

   Guardar(){
    this.srvObj.AgregarEditar(this.obj,this.obj.IdDependenciaUsuario).subscribe((band)=>{
      if(band){

        Swal.fire("Ok","La operación se realizó con éxito",'success');
        this.route.navigate(['admin/perfiles'])
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