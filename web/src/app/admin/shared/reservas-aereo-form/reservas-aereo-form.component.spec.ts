import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReservasAereoFormComponent } from './reservas-aereo-form.component';

describe('ReservasAereoFormComponent', () => {
  let component: ReservasAereoFormComponent;
  let fixture: ComponentFixture<ReservasAereoFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReservasAereoFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReservasAereoFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
