import { TestBed } from '@angular/core/testing';

import { GdReportListService } from './gdreport-list.service';

describe('GdReportListService', () => {
  let service: GdReportListService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GdReportListService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
