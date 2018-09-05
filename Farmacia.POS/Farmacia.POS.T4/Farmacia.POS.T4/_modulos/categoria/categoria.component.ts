import { Component, OnInit } from '@angular/core';
import { CategoriaService } from '../../_servicios/categoria.service';
import { MensajeEstatus } from '../../_modelos/mensaje.enum';

@Component({
  selector: 'app-categoria',
  templateUrl: './categoria.component.html',
  styleUrls: ['./categoria.component.css']
})
export class CategoriaComponent implements OnInit {
  Categorias: any[];
  cols: any[];
  titulo = 'Categorias';  
  constructor(public servicio: CategoriaService) { 
        this.cols = [
          { field: 'codigo', header: 'Codigo' },
          { field: 'descripcion', header: 'Descripcion' },
          { field: 'fecha', header: 'Fecha' },
        ]; 
  }


  ngOnInit() {
    this.get();
  }

  get() {
    this.servicio.getAll(1, 0).subscribe(data => {
      this.Categorias = data['items'];
    });
  }
}


