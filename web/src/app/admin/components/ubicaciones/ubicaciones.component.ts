import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Ubicaciones } from 'src/app/models/Ubicaciones.model';
import { SharedService } from 'src/app/services/shared/shared.service';
import { UbicacionesService } from 'src/app/services/ubicaciones/ubicaciones.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-ubicaciones',
  templateUrl: './ubicaciones.component.html',
  styleUrls: ['./ubicaciones.component.scss']
})
export class UbicacionesComponent implements OnInit {

  ArrObj:Ubicaciones[]=[];
  page = 1;
  pageSize = 10;
  collectionSize = 0
  OriginalArr:Ubicaciones[]=[];
  strFiltro="";
  constructor(private srvObj:UbicacionesService,private srvShared:SharedService,private router:Router,private route:ActivatedRoute) {
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

  Borrar(obj:Ubicaciones){
    Swal.fire({
      title: "Atención",
      text:"¿Está seguro que desea borrar?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      if (result.isConfirmed) {
        this.srvObj.borrar(obj.IdUbicacion).subscribe((band)=>{
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

  
  Editar(obj:Ubicaciones){
    this.srvShared.ObjEdit=obj;
    this.router.navigate(['admin/ubicacionesForm']);
  }
  Nuevo(){
    this.srvShared.ObjEdit=null;
    this.router.navigate(['admin/ubicacionesForm']);
  }

}
