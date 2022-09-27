import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { MainComponent } from './components/main/main.component';
import { PerfilesComponent } from './components/perfiles/perfiles.component';



const routes: Routes = [
  {
    path: '',
    component: MainComponent,
    children:[
      
      {
        path: 'perfiles',
        component: PerfilesComponent,
      },
      
      

    ]
  }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
