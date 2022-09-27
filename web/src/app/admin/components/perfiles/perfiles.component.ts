import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-perfiles',
  templateUrl: './perfiles.component.html',
  styleUrls: ['./perfiles.component.scss']
})
export class PerfilesComponent implements OnInit {
  collectionSize:number=0;
  page:number=1;
  pageSize:number = 20;
  strFiltro="";
  obj:any;
  constructor() { }

  ngOnInit(): void {
  }
  refreshData(){
    
  }

}
