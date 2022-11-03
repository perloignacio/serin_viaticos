import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { UsuariosDependencia } from 'src/app/models/UsuariosDependencia.model';
import { SharedService } from 'src/app/services/shared/shared.service';
import { UsuariosDependenciaService } from 'src/app/services/usuariosDependencia/usuarios-dependencia.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-usuarios-dependencia',
  templateUrl: './usuarios-dependencia.component.html',
  styleUrls: ['./usuarios-dependencia.component.scss']
})
export class UsuariosDependenciaComponent implements OnInit {

  ArrObj:UsuariosDependencia[]=[];
  page = 1;
  pageSize = 10;
  collectionSize = 0
  OriginalArr:UsuariosDependencia[]=[];
  strFiltro="";
  constructor(private srvObj:UsuariosDependenciaService,private srvShared:SharedService,private router:Router,private route:ActivatedRoute) {
    this.cargar()
  }

  cargar(){
    this.route.params.subscribe(val => {     
      this.srvObj.todos().subscribe((lista)=>{
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
      return obj.IdDependenciaUsuario.toString().includes(term)      
    });
  }

  ngOnInit(): void {
  }

  Borrar(obj:UsuariosDependencia){
    Swal.fire({
      title: "Atención",
      text:"¿Está seguro que desea borrar?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      if (result.isConfirmed) {
        this.srvObj.borrar(obj.IdDependenciaUsuario).subscribe((band)=>{
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

  Editar(obj:UsuariosDependencia){
    this.srvShared.ObjEdit=obj;
    this.router.navigate(['admin/usuariosDependenciaForm']);
  }
  Nuevo(){
    this.srvShared.ObjEdit=null;
    this.router.navigate(['admin/usuariosDependenciaForm']);
  }
}