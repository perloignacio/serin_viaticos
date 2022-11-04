import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Ubicaciones } from 'src/app/models/Ubicaciones.model';
import { environment } from 'src/environments/environment';
const httpOptions = {
  withCredentials: true
};
@Injectable({
  providedIn: 'root'
})
export class UbicacionesService {

  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"ubicaciones/";
  }

  borrar(id:number) {
    return this.httpClient.delete<boolean>(this.endpoint + `Borrar/${id}`, httpOptions)
  }

  todas() {
    return this.httpClient.get<Ubicaciones[]>(this.endpoint + `GetTodos`, httpOptions)
  }



  AgregarEditar(form:any,id?:number) {
    return this.httpClient.post<boolean>(this.endpoint+`AgregarEditar/${id}`,form);
  }
}
