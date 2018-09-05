import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseService } from './base.service';
import { ToasterService } from 'angular2-toaster';
@Injectable()
export class TiposMovimientoService extends BaseService {
 constructor(public http: HttpClient, toasterService: ToasterService) {
    super(http, 'tiposMovimiento', toasterService);
  }

  getProfile(id: string) {
    const url = this.actionUrl + '/' + id;
    return this.http.get(url, this.httpOptions);
  }
}
