import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { UsuariosDependencia } from 'src/app/models/UsuariosDependencia.model';
import { environment } from 'src/environments/environment';

const httpOptions = {
  withCredentials: true
};

@Injectable({
  providedIn: 'root'
})
export class UsuariosDependenciaService {
  
  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"UsuariosDependencia/";
  }

  todos() {
    return this.httpClient.get<UsuariosDependencia[]>(this.endpoint + `GetTodos`, httpOptions)
  }

  AgregarEditar(form:any,id?:number) {
    return this.httpClient.post<boolean>(this.endpoint+`AgregarEditar/${id}`,form);
  }

  borrar(id:number) {
    return this.httpClient.delete<boolean>(this.endpoint + `Borrar/${id}`, httpOptions)
  }

  activar(id:number) {
    return this.httpClient.post<boolean>(this.endpoint + `Activar/${id}`, httpOptions)
  }
}

