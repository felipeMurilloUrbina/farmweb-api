import { Component, OnInit } from '@angular/core';
import { EmpresaService } from '../../_servicios/empresa.service';
import { MensajeEstatus } from '../../_modelos/mensaje.enum';

@Component({
  selector: 'app-empresa',
  templateUrl: './empresa.component.html',
  styleUrls: ['./empresa.component.css']
})
export class EmpresaComponent implements OnInit {
  Empresas: any[];
  cols: any[];
  titulo = 'Empresas';  
  constructor(public servicio: EmpresaService) { 
        this.cols = [
        ]; 
  }


  ngOnInit() {
    this.get();
  }

  get() {
    this.servicio.getAll(1, 0).subscribe(data => {
      this.Empresas = data['items'];
    });
  }
}


