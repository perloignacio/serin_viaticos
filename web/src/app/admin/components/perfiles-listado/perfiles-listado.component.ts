import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Perfiles } from 'src/app/models/Perfiles.model';
import { PerfilesService } from 'src/app/services/perfiles/perfiles.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-perfiles-listado',
  templateUrl: './perfiles-listado.component.html',
  styleUrls: ['./perfiles-listado.component.scss']
})
export class PerfilesListadoComponent implements OnInit {

Agregar:boolean=true;
  obj:Perfiles;

  constructor(private srvObj:PerfilesService,private srvShared:SharedService,private route:Router) {
    this.obj=this.srvShared.ObjEdit as Perfiles;
      if(this.obj!=null){
        this.Agregar=false;
      }else{
        this.obj=new Perfiles();
      }
   }

   Guardar(){
    this.srvObj.AgregarEditar(this.obj,this.obj.IdPerfil).subscribe((band)=>{
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