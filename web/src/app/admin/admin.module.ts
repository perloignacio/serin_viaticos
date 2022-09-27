import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { AdminRoutingModule } from './admin.routing';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import{TopComponent} from './shared/top/top.component'
import{MenuBarComponent} from './shared/menu-bar/menu-bar.component';
import { MainComponent } from './components/main/main.component';

import { NgxSpinnerModule } from 'ngx-spinner';
import { LightboxModule } from 'ngx-lightbox';
import { FileSaverModule } from 'ngx-filesaver';
import { PerfilesComponent } from './components/perfiles/perfiles.component';


@NgModule({
  declarations: [
    TopComponent,
    MenuBarComponent,
    MainComponent,
    PerfilesComponent
   
  ],
  exports:[
    MainComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    AdminRoutingModule,
    NgbModule,
    PerfectScrollbarModule,
    FormsModule,
    ReactiveFormsModule,
    NgxSpinnerModule,
    LightboxModule,
    FileSaverModule 
  ],providers:[
    DatePipe
  ]
})
export class AdminModule { }
