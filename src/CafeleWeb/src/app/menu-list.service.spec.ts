import { TestBed } from '@angular/core/testing';

import { MenuListService } from './menu-list.service';

describe('MenuListService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: MenuListService = TestBed.get(MenuListService);
    expect(service).toBeTruthy();
  });
});
