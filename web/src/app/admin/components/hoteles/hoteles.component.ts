import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Hoteles } from 'src/app/models/Hoteles.model';
import { HotelesService } from 'src/app/services/hoteles/hoteles.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-hoteles',
  templateUrl: './hoteles.component.html',
  styleUrls: ['./hoteles.component.scss']
})
export class HotelesComponent implements OnInit {

  ArrObj:Hoteles[]=[];
  page = 1;
  pageSize = 10;
  collectionSize = 0
  OriginalArr:Hoteles[]=[];
  strFiltro="";
  constructor(private srvObj:HotelesService,private srvShared:SharedService,private router:Router,private route:ActivatedRoute) {
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
      return obj.Nombre.toLowerCase().includes(term)
      ||obj.Direccion.toLowerCase().includes(term)
      ||obj.Email.toLowerCase().includes(term)      
    });
  }

  ngOnInit(): void {
  }

  Borrar(obj:Hoteles){
    Swal.fire({
      title: "Atención",
      text:"¿Está seguro que desea borrar?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      if (result.isConfirmed) {
        this.srvObj.borrar(obj.IdHotel).subscribe((band)=>{
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

  
  Editar(obj:Hoteles){
    this.srvShared.ObjEdit=obj;
    this.router.navigate(['admin/hotelesForm']);
  }
  Nuevo(){
    this.srvShared.ObjEdit=null;
    this.router.navigate(['admin/hotelesForm']);
  }
}