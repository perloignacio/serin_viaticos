import { SolicitudesDetalle } from "./SolcitudesDetalle.model";
import { SolicitudesEstados } from "./SolicitudesEstados.model";
import { SolicitudesUsuario } from "./SolicitudesUsuarios.model";
import { Usuario } from "./Usuario.model";

export class Solicitudes{
    IdSolicitud: number;
    Fecha: Date;
    IdUsuario: number;
    IdSolicitudEstado: number;
    EmailCopia: string;
    Descripcion: string;
    Detalle:SolicitudesDetalle[]=[];
    SolcitudesUsuarios:SolicitudesUsuario[]=[];
    Usuario:Usuario;
    SolicitudesEstadosEntity:SolicitudesEstados
    
}