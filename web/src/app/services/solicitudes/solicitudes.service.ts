import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Solicitudes } from 'src/app/models/Solicitudes.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SolicitudesService {

  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"Solicitudes/";
  }

  AgregarEditar(form:any,id?:number) {
    return this.httpClient.post<boolean>(this.endpoint+`AgregarEditar/${id}`,form);
  }
  todas() {
    return this.httpClient.get<Solicitudes[]>(this.endpoint+`GetTodos/`);
  }
}
