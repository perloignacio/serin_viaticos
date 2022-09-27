import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import { SharedService } from 'src/app/services/shared/shared.service';

@Component({
  selector: 'app-menu-bar',
  templateUrl: './menu-bar.component.html',
  styleUrls: ['./menu-bar.component.css']
})
export class MenuBarComponent implements OnInit {
  
  constructor(public srvAut:AuthenticationService,private route:Router) { }
  Salir(){
    this.srvAut.logout();
    this.route.navigate(["/login"])
  }
  ngOnInit(): void {
  }

}
