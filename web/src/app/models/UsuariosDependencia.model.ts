import { Usuario } from "./Usuario.model";

export class UsuariosDependencia{
    IdDependenciaUsuario:number;
    IdUsuarioHijo: number;
    NombreHijoEntity:Usuario;
    ApellidoHijoEntity:Usuario;
    IdUsuarioPadre:number;
    NombrePadreEntity:Usuario;
    ApellidoPadreEntity:Usuario;
}