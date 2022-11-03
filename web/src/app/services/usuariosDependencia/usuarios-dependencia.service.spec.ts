import { TestBed } from '@angular/core/testing';

import { UsuariosDependenciaService } from './usuarios-dependencia.service';

describe('UsuariosDependenciaService', () => {
  let service: UsuariosDependenciaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UsuariosDependenciaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
