import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoriasListadoComponent } from './components/categorias-listado/categorias-listado.component';
import { CategoriasComponent } from './components/categorias/categorias.component';
import { MainComponent } from './components/main/main.component';
import { PerfilesListadoComponent } from './components/perfiles-listado/perfiles-listado.component';
import { PerfilesComponent } from './components/perfiles/perfiles.component';
import { UsuariosComponent } from './components/usuarios/usuarios.component';


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
        path: 'usuarios',
        component: UsuariosComponent,
      },      
    ]
  }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
