import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Categorias } from 'src/app/models/Categorias.model';
import { CategoriasService } from 'src/app/services/categorias/categorias.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-categorias-listado',
  templateUrl: './categorias-listado.component.html',
  styleUrls: ['./categorias-listado.component.scss']
})
export class CategoriasListadoComponent implements OnInit {
  Agregar:boolean=true;
  obj:Categorias;

  constructor(private srvObj:CategoriasService,private srvShared:SharedService,private route:Router) {
    this.obj=this.srvShared.ObjEdit as Categorias;
      if(this.obj!=null){
        this.Agregar=false;
      }else{
        this.obj=new Categorias();
      }
   }

   Guardar(){
    
    this.srvObj.AgregarEditar(this.obj,this.obj.IdCategoriaGasto).subscribe((band)=>{
      if(band){

        Swal.fire("Ok","La operación se realizó con éxito",'success');
        this.route.navigate(['admin/categorias'])
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