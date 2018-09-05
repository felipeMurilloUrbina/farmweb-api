import { Component, OnInit } from '@angular/core';
import { SucursalService } from '../../_servicios/sucursal.service';
import { MensajeEstatus } from '../../_modelos/mensaje.enum';

@Component({
  selector: 'app-sucursal',
  templateUrl: './sucursal.component.html',
  styleUrls: ['./sucursal.component.css']
})
export class SucursalComponent implements OnInit {
  Sucursales: any[];
  cols: any[];
  titulo = 'Sucursales';  
  constructor(public servicio: SucursalService) { 
        this.cols = [
          { field: 'codigo', header: 'Codigo' },
          { field: 'descripcion', header: 'Descripcion' },
          { field: 'nombreComercial', header: 'NombreComercial' },
          { field: 'rfc', header: 'RFC' },
          { field: 'municipio', header: 'Municipio' },
        ]; 
  }


  ngOnInit() {
    this.get();
  }

  get() {
    this.servicio.getAll(1, 0).subscribe(data => {
      this.Sucursales = data['items'];
    });
  }
}


