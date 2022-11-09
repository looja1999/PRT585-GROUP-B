import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditGdReportComponent } from './edit-gdreport.component';

describe('EditGdReportComponent', () => {
  let component: EditGdReportComponent;
  let fixture: ComponentFixture<EditGdReportComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditGdReportComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditGdReportComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
