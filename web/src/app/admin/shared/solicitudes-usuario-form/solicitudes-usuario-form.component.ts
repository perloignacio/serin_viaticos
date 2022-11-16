import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { SolicitudesUsuario } from 'src/app/models/SolicitudesUsuarios.model';
import { Usuario } from 'src/app/models/Usuario.model';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import { SharedService } from 'src/app/services/shared/shared.service';

@Component({
  selector: 'app-solicitudes-usuario-form',
  templateUrl: './solicitudes-usuario-form.component.html',
  styleUrls: ['./solicitudes-usuario-form.component.scss']
})
export class SolicitudesUsuarioFormComponent implements OnInit {
  obj:SolicitudesUsuario=new SolicitudesUsuario();
  usuarios:Usuario[]=[];
  agregar:boolean=true;
  constructor(private modal:NgbActiveModal,private srvShared:SharedService,private srvAuth:AuthenticationService) {

    this.srvAuth.todos().subscribe((lu)=>{
      this.usuarios=lu;
      if(this.srvShared.objModal as SolicitudesUsuario!=null){
        this.agregar=false;
        this.obj=this.srvShared.objModal as SolicitudesUsuario;
      }else{
        this.obj=new SolicitudesUsuario();
      }
    })
  }

  Guardar(){
    this.obj.UsuariosEntity=this.usuarios.find(u=>u.IdUsuario==this.obj.IdUsuario);
    if(this.agregar){
      this.obj.IdSolicitudUsuario=Math.floor(Math.random() * 10000000);
    }
    this.modal.close(this.obj);
  }

  ngOnInit(): void {
  }
  cerrar(){
    this.modal.close();
  }
}
