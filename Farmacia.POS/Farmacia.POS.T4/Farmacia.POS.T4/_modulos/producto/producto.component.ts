import { Component, OnInit } from '@angular/core';
import { ProductoService } from '../../_servicios/producto.service';
import { MensajeEstatus } from '../../_modelos/mensaje.enum';

@Component({
  selector: 'app-producto',
  templateUrl: './producto.component.html',
  styleUrls: ['./producto.component.css']
})
export class ProductoComponent implements OnInit {
  Productos: any[];
  cols: any[];
  titulo = 'Productos';  
  constructor(public servicio: ProductoService) { 
        this.cols = [
          { field: 'codigo', header: 'Codigo' },
          { field: 'descripcion', header: 'Descripcion' },
          { field: 'precio', header: 'Precio' },
          { field: 'fecha', header: 'Fecha' },
        ]; 
  }


  ngOnInit() {
    this.get();
  }

  get() {
    this.servicio.getAll(1, 0).subscribe(data => {
      this.Productos = data['items'];
    });
  }
}


