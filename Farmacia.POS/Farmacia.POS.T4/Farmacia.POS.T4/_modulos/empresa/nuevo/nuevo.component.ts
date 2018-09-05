import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { EmpresaService } from '../../../_servicios/empresa.service';
import { Empresa } from '../../../_modelos/empresa.model';
import { MensajeEstatus } from '../../../_modelos/mensaje.enum';

@Component({
  selector: 'app-nuevo-empresa',
  templateUrl: './nuevo.component.html',
  styleUrls: ['./nuevo.component.css']
})
export class NuevoEmpresaComponent implements OnInit {
  Empresas: any[];
  cols: any[];
  titulo = 'Nuevo Empresa';
  empresa: Empresa;
  constructor(private router: Router, private route: ActivatedRoute, private fb: FormBuilder, private servicio: EmpresaService) {
    this.empresa = new Empresa();
    this.route.params
      .subscribe(params => {
        if (params['id'] !== undefined) {
            this.empresa.id = params['id'];
            this.getId(params['id']);
        }
      });
  }

  ngOnInit() {
    this.get();
  }

  get() {
    if(this.empresa.id) {
        this.servicio.getId(this.empresa.id).subscribe(data => {
          this.empresa = data['item'];
        });
    }
  }
  
  limpiar() {
  }

  regresar() {
    this.router.navigate(['/admin/empresas'], { queryParams: {} });
  }

  validar() {
  }
  
  guardar() {
    this.servicio.post(this.empresa, '').subscribe( dato => {
        this.servicio.enviarMensaje(MensajeEstatus.ok, 'Empresas', dato);
        this.limpiar();
    });
  }
}
