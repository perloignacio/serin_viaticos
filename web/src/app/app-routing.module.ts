import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { AuthGuardService } from './services/AuthGuardService/auth-guard.service';

const routes: Routes = [
  
  {
    path:'',
    component:LoginComponent,
  },
  {
    path:'login',
    component:LoginComponent,
  },
  {
     path: 'admin', loadChildren: () => import('./admin/admin.module').then(m => m.AdminModule),
     canLoad: [ AuthGuardService ],
     canActivate:[AuthGuardService],

  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
