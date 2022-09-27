import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  usuario:string;
  contra:string;
  constructor(private svcAuthentication:AuthenticationService,private router:Router) { }

  ngOnInit(): void {
  }
  Ingresar(){
    this.svcAuthentication.login(this.usuario,this.contra).subscribe((u)=>{
      if(u!=null){
        
          this.router.navigate(['/admin/perfiles']);
       

      }
    },(err)=>{
      console.log(err);
      Swal.fire("Upps",err.error.Message,'warning');
    })
  }
}
