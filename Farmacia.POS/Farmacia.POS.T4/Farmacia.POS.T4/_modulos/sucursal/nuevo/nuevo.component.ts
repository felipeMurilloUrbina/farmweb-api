import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { SucursalService } from '../../../_servicios/sucursal.service';
import { Sucursal } from '../../../_modelos/sucursal.model';
import { MensajeEstatus } from '../../../_modelos/mensaje.enum';

@Component({
  selector: 'app-nuevo-sucursal',
  templateUrl: './nuevo.component.html',
  styleUrls: ['./nuevo.component.css']
})
export class NuevoSucursalComponent implements OnInit {
  Sucursales: any[];
  cols: any[];
  titulo = 'Nuevo Sucursal';
  sucursal: Sucursal;
  constructor(private router: Router, private route: ActivatedRoute, private fb: FormBuilder, private servicio: SucursalService) {
    this.sucursal = new Sucursal();
    this.route.params
      .subscribe(params => {
        if (params['id'] !== undefined) {
            this.sucursal.id = params['id'];
            this.getId(params['id']);
        }
      });
  }

  ngOnInit() {
    this.get();
  }

  get() {
    if(this.sucursal.id) {
        this.servicio.getId(this.sucursal.id).subscribe(data => {
          this.sucursal = data['item'];
        });
    }
  }
  
  limpiar() {
  }

  regresar() {
    this.router.navigate(['/admin/sucursales'], { queryParams: {} });
  }

  validar() {
  }
  
  guardar() {
    this.servicio.post(this.sucursal, '').subscribe( dato => {
        this.servicio.enviarMensaje(MensajeEstatus.ok, 'Sucursales', dato);
        this.limpiar();
    });
  }
}
