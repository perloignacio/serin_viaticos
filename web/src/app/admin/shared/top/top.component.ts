import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { is } from 'date-fns/locale';
import { Observable } from 'rxjs';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import { SharedService } from 'src/app/services/shared/shared.service';

@Component({
  selector: 'app-top',
  templateUrl: './top.component.html',
  styleUrls: ['./top.component.css']
})
export class TopComponent implements OnInit {
  
  isActive:boolean=false;
  constructor(private srvAut:AuthenticationService,private route:Router,private srvShared:SharedService) { 
    this.srvShared.getActive$().subscribe((b)=>{
      this.isActive=b;
      console.log(this.isActive);
    });
  }
  Salir(){
    this.srvAut.logout();
    this.route.navigate(["/login"])
  }
  cambiaActive(){
    console.log("llego",this.isActive);
    this.srvShared.setActive(!this.isActive);
  }
  ngOnInit(): void {
    
    
  }

}
