import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { TiposMovimientoService } from '../../../_servicios/tipos-movimiento.service';
import { TiposMovimiento } from '../../../_modelos/tipos-movimiento.model';
import { MensajeEstatus } from '../../../_modelos/mensaje.enum';

@Component({
  selector: 'app-nuevo-tipos-movimiento',
  templateUrl: './nuevo.component.html',
  styleUrls: ['./nuevo.component.css']
})
export class NuevoTiposMovimientoComponent implements OnInit {
  TiposMovimiento: any[];
  cols: any[];
  titulo = 'Nuevo TiposMovimiento';
  tiposMovimiento: TiposMovimiento;
  constructor(private router: Router, private route: ActivatedRoute, private fb: FormBuilder, private servicio: TiposMovimientoService) {
    this.tiposMovimiento = new TiposMovimiento();
    this.route.params
      .subscribe(params => {
        if (params['id'] !== undefined) {
            this.tiposMovimiento.id = params['id'];
            this.getId(params['id']);
        }
      });
  }

  ngOnInit() {
    this.get();
  }

  get() {
    if(this.tiposMovimiento.id) {
        this.servicio.getId(this.tiposMovimiento.id).subscribe(data => {
          this.tiposMovimiento = data['item'];
        });
    }
  }
  
  limpiar() {
  }

  regresar() {
    this.router.navigate(['/admin/tipos-movimiento'], { queryParams: {} });
  }

  validar() {
  }
  
  guardar() {
    this.servicio.post(this.tiposMovimiento, '').subscribe( dato => {
        this.servicio.enviarMensaje(MensajeEstatus.ok, 'TiposMovimiento', dato);
        this.limpiar();
    });
  }
}
