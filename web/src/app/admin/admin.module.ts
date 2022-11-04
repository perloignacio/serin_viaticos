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
import { CategoriasComponent } from './components/categorias/categorias.component';
import { PerfilesListadoComponent } from './components/perfiles-listado/perfiles-listado.component';
import { CategoriasListadoComponent } from './components/categorias-listado/categorias-listado.component';
import { UsuariosDependenciaComponent } from './components/usuarios-dependencia/usuarios-dependencia.component';
import { UsuariosDependenciaFormComponent } from './components/usuarios-dependencia-form/usuarios-dependencia-form.component';
import { HotelesComponent } from './components/hoteles/hoteles.component';
import { HotelesFormComponent } from './components/hoteles-form/hoteles-form.component';

import { UbicacionesComponent } from './components/ubicaciones/ubicaciones.component';
import { UbicacionesFormComponent } from './components/ubicaciones-form/ubicaciones-form.component';
import { AgmCoreModule } from '@agm/core';


@NgModule({
  declarations: [
    TopComponent,
    MenuBarComponent,
    MainComponent,
    PerfilesComponent,
    CategoriasComponent,
    PerfilesListadoComponent,
    CategoriasListadoComponent,
    UsuariosDependenciaComponent,
    UsuariosDependenciaFormComponent,
    HotelesComponent,
    HotelesFormComponent,
    UbicacionesComponent,
    UbicacionesFormComponent,
  
   
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
    FileSaverModule ,
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyCg8BmxqFCCKSEdoT7JQXXM5zDHqrIkx0g',
      libraries: ['places']
    }) 
  ],providers:[
    DatePipe
  ]
})
export class AdminModule { }
