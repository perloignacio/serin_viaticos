import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Perfiles } from 'src/app/models/Perfiles.model';
import { PerfilesService } from 'src/app/services/perfiles/perfiles.service';
import { SharedService } from 'src/app/services/shared/shared.service';

import Swal from 'sweetalert2';

@Component({
  selector: 'app-perfiles',
  templateUrl: './perfiles.component.html',
  styleUrls: ['./perfiles.component.scss']
})
export class PerfilesComponent implements OnInit {

  ArrObj:Perfiles[]=[];
  page = 1;
  pageSize = 10;
  collectionSize = 0
  OriginalArr:Perfiles[]=[];
  strFiltro="";
  constructor(private srvObj:PerfilesService,private srvShared:SharedService,private router:Router,private route:ActivatedRoute) {
    this.cargar()
  }

  cargar(){
    this.route.params.subscribe(val => {     
      this.srvObj.todas().subscribe((lista)=>{
        this.OriginalArr=lista;
        this.collectionSize=this.OriginalArr.length;
        this.refreshData();
      })
    })
  }
  refreshData(){
    this.ArrObj=this.OriginalArr.slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);
  }
  Filtro(){
    
    this.ArrObj=this.OriginalArr.filter(obj => {
      const term = this.strFiltro.toLowerCase();
      return obj.Nombre.toLowerCase().includes(term)      
    });
  }

  ngOnInit(): void {
  }

  Borrar(obj:Perfiles){
    Swal.fire({
      title: "Atención",
      text:"¿Está seguro que desea borrar?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      if (result.isConfirmed) {
        this.srvObj.borrar(obj.IdPerfil).subscribe((band)=>{
          if(band){
            this.cargar();
            Swal.fire("Ok","Se borró el registro",'success');

          }
        },(err)=>{
          this.cargar();
          Swal.fire("Upps",err.error.Message,'warning');
        })
      };
    });
  }

  Activar(obj:Perfiles){
    Swal.fire({
      title: "Atención",
      text:"¿Está seguro que desea activar este registro?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      if (result.isConfirmed) {
        this.srvObj.activar(obj.IdPerfil).subscribe((band)=>{
          if(band){
            this.cargar();
            Swal.fire("Ok","Se activó el registro",'success');

          }
        },(err)=>{
          this.cargar();
          Swal.fire("Upps",err.error.Message,'warning');
        })
      };
    });

  }
  Editar(obj:Perfiles){
    this.srvShared.ObjEdit=obj;
    this.router.navigate(['admin/perfilesListado']);
  }
  Nuevo(){
    this.srvShared.ObjEdit=null;
    this.router.navigate(['admin/perfilesListado']);
  }
}