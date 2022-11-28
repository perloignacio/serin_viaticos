import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Solicitudes } from 'src/app/models/Solicitudes.model';
import { SharedService } from 'src/app/services/shared/shared.service';
import { SolicitudesService } from 'src/app/services/solicitudes/solicitudes.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-solicitudes-listado',
  templateUrl: './solicitudes-listado.component.html',
  styleUrls: ['./solicitudes-listado.component.scss']
})
export class SolicitudesListadoComponent implements OnInit {

ArrObj:Solicitudes[]=[];
page = 1;
pageSize = 10;
collectionSize = 0
OriginalArr:Solicitudes[]=[];
strFiltro="";
constructor(private srvObj:SolicitudesService,private srvShared:SharedService,private router:Router,private route:ActivatedRoute) {
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
    return obj.Usuario.Nombre.toLowerCase().includes(term)||obj.Usuario.Apellido.toLowerCase().includes(term) ||obj.SolicitudesEstadosEntity.Nombre.toLowerCase().includes(term)||obj.Descripcion.toLowerCase().includes(term)      
  });
}

ngOnInit(): void {
}

Borrar(obj:Solicitudes){
  Swal.fire({
    title: "Atención",
    text:"¿Está seguro que desea borrar?",
    icon:'warning',
    showDenyButton: true,
    confirmButtonText: 'Aceptar',
    denyButtonText: `Cancelar`,
  }).then((result) => {
    if (result.isConfirmed) {
      /*this.srvObj.borrar(obj.IdSolicitudCategoria).subscribe((band)=>{
        if(band){
          this.cargar();
          Swal.fire("Ok","Se borró el registro",'success');
        }

      },(err)=>{
        this.cargar();
        Swal.fire("Upps",err.error.Message,'warning');
      })*/
    };
  });
}

Nuevo(){
  
  this.router.navigate(['admin/solicitudes']);
}
  Editar(obj:Solicitudes){
    this.srvShared.ObjEdit=obj;
    this.router.navigate(['admin/solicitudes']);
  }
 
}
