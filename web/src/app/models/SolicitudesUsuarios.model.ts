import { Solicitudes } from "./Solicitudes.model";
import { Usuario } from "./Usuario.model";

export class SolicitudesUsuario{
    IdSolicitudUsuario:number;
    IdSolicitud:number;
    IdUsuario:number;
    MontoAnticipo?:number;
    SolicitudesEntity:Solicitudes;
    UsuariosEntity:Usuario;
}