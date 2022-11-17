import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
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
  }}
