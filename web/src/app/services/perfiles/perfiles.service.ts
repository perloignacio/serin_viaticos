import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Perfiles } from 'src/app/models/Perfiles.model';
import { environment } from 'src/environments/environment';

const httpOptions = {
  withCredentials: true
};

@Injectable({
  providedIn: 'root'
})
export class PerfilesService {
  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"perfiles/";
  }

  borrar(id:number) {
    return this.httpClient.delete<boolean>(this.endpoint + `Borrar/${id}`, httpOptions)
  }

  todas() {
    return this.httpClient.get<Perfiles[]>(this.endpoint + `GetTodos`, httpOptions)
  }

  activar(id:number) {
    return this.httpClient.post<boolean>(this.endpoint + `Activar/${id}`, httpOptions)
  }

  AgregarEditar(form:any,id?:number) {
    return this.httpClient.post<boolean>(this.endpoint+`AgregarEditar/${id}`,form);
  }
}
