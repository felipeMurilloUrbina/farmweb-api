import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { EntradaService } from '../../../_servicios/entrada.service';
import { Entrada } from '../../../_modelos/entrada.model';
import { MensajeEstatus } from '../../../_modelos/mensaje.enum';

@Component({
  selector: 'app-nuevo-entrada',
  templateUrl: './nuevo.component.html',
  styleUrls: ['./nuevo.component.css']
})
export class NuevoEntradaComponent implements OnInit {
  Entradas: any[];
  cols: any[];
  titulo = 'Nuevo Entrada';
  entrada: Entrada;
  constructor(private router: Router, private route: ActivatedRoute, private fb: FormBuilder, private servicio: EntradaService) {
    this.entrada = new Entrada();
    this.route.params
      .subscribe(params => {
        if (params['id'] !== undefined) {
            this.entrada.id = params['id'];
            this.getId(params['id']);
        }
      });
  }

  ngOnInit() {
    this.get();
  }

  get() {
    if(this.entrada.id) {
        this.servicio.getId(this.entrada.id).subscribe(data => {
          this.entrada = data['item'];
        });
    }
  }
  
  limpiar() {
  }

  regresar() {
    this.router.navigate(['/admin/entradas'], { queryParams: {} });
  }

  validar() {
  }
  
  guardar() {
    this.servicio.post(this.entrada, '').subscribe( dato => {
        this.servicio.enviarMensaje(MensajeEstatus.ok, 'Entradas', dato);
        this.limpiar();
    });
  }
}
