import { Component, OnInit } from '@angular/core';
import { EntradaService } from '../../_servicios/entrada.service';
import { MensajeEstatus } from '../../_modelos/mensaje.enum';

@Component({
  selector: 'app-entrada',
  templateUrl: './entrada.component.html',
  styleUrls: ['./entrada.component.css']
})
export class EntradaComponent implements OnInit {
  Entradas: any[];
  cols: any[];
  titulo = 'Entradas';  
  constructor(public servicio: EntradaService) { 
        this.cols = [
          { field: 'fecha', header: 'Fecha' },
        ]; 
  }


  ngOnInit() {
    this.get();
  }

  get() {
    this.servicio.getAll(1, 0).subscribe(data => {
      this.Entradas = data['items'];
    });
  }
}


