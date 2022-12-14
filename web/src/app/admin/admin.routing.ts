import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoriasListadoComponent } from './components/categorias-listado/categorias-listado.component';
import { CategoriasComponent } from './components/categorias/categorias.component';
import { HotelesFormComponent } from './components/hoteles-form/hoteles-form.component';
import { HotelesComponent } from './components/hoteles/hoteles.component';
import { MainComponent } from './components/main/main.component';
import { PerfilesListadoComponent } from './components/perfiles-listado/perfiles-listado.component';
import { PerfilesComponent } from './components/perfiles/perfiles.component';
import { SolicitudesListadoComponent } from './components/solicitudes-listado/solicitudes-listado.component';
import { SolicitudesComponent } from './components/solicitudes/solicitudes.component';
import { UbicacionesFormComponent } from './components/ubicaciones-form/ubicaciones-form.component';
import { UbicacionesComponent } from './components/ubicaciones/ubicaciones.component';
import { UsuariosDependenciaFormComponent } from './components/usuarios-dependencia-form/usuarios-dependencia-form.component';
import { UsuariosDependenciaComponent } from './components/usuarios-dependencia/usuarios-dependencia.component';



const routes: Routes = [
  {
    path: '',
    component: MainComponent,
    children:[
      {
        path: 'categorias',
        component: CategoriasComponent,
      },
      {
        path: 'perfiles',
        component: PerfilesComponent,
      },
      {
        path: 'perfilesListado',
        component: PerfilesListadoComponent,
      },
      {
        path: 'categoriasListado',
        component: CategoriasListadoComponent,
      },
      {
        path: 'usuariosDependencia',
        component: UsuariosDependenciaComponent,
      },
      {
        path: 'usuariosDependenciaForm',
        component: UsuariosDependenciaFormComponent,
      },
      {
        path: 'ubicaciones',
        component: UbicacionesComponent,
      },
      {
        path: 'ubicacionesForm',
        component: UbicacionesFormComponent,
      },
      {
        path: 'hoteles',
        component: HotelesComponent,
      },
      {
        path: 'hotelesForm',
        component: HotelesFormComponent,
      },
      {
        path: 'solicitudes',
        component: SolicitudesComponent,
      },
      {
        path: 'solicitudes-listado',
        component: SolicitudesListadoComponent,
      },
    ]
  }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
