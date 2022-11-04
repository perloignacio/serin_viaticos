import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Hoteles } from 'src/app/models/Hoteles.model';
import { environment } from 'src/environments/environment';

const httpOptions = {
  withCredentials: true
};

@Injectable({
  providedIn: 'root'
})
export class HotelesService {
  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"Hoteles/";
  }

  todos() {
    return this.httpClient.get<Hoteles[]>(this.endpoint + `GetTodos`, httpOptions)
  }

  AgregarEditar(form:any,id?:number) {
    return this.httpClient.post<boolean>(this.endpoint+`AgregarEditar/${id}`,form);
  }

  borrar(id:number) {
    return this.httpClient.delete<boolean>(this.endpoint + `Borrar/${id}`, httpOptions)
  }

}