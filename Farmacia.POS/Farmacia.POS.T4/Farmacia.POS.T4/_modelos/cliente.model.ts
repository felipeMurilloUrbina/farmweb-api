export class Cliente {
  public id: number;
  public empresaId: number;
  public grupoId: number;
  public usuarioCreadorId: number;
  public usuarioModificadorId: number;
  public descripcion: string;
  public calle: string;
  public colonia: string;
  public ciudad: string;
  public codigoPostal: string;
  public municipio: string;
  public estado: string;
  public pais: string;
  public telefono: string;
  public celular: string;
  public nombreContacto: string;
  public rfc: string;
  public correo: string;
  public fecha: Date;
  public activo: string;
  public tieneCredito: string;
  public diasCredito: number;
  public limiteCredito: number;
  public descuento: number;
}
