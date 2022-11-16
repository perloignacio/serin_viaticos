import { SolicitudesDetalle } from "./SolcitudesDetalle.model";
import { SolicitudesUsuario } from "./SolicitudesUsuarios.model";

export class Solicitudes{
    IdSolicitud: number;
    Fecha: Date;
    IdUsuario: number;
    IdSolicitudEstado: number;
    EmailCopia: string;
    Descripcion: string;
    Detalle:SolicitudesDetalle[]=[];
    SolcitudesUsuarios:SolicitudesUsuario[]=[];
}