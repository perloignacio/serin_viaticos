import { Usuario } from "./Usuario.model";

export class UsuariosDependencia{
    IdUsuarioDependencia:number;
    IdUsuarioHijo: number;
    UsuarioHijo:Usuario;
    UsuarioPadre:Usuario;
    IdUsuarioPadre:number;
    ApellidoHijo:string;
}