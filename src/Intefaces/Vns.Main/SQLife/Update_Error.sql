update kt_ct_h_khac set ngay_sua = '1753-01-01',
ngay_pd = '1753-01-01', ngay_khoa_so = '1753-01-01', bx_ngay_1 = '1753-01-01',
bx_ngay_2 = '1753-01-01', bx_ngay_3 = '1753-01-01'
where ngay_sua = '0002-01-01'

update kt_ct_d_khac set ct_ghiso_ngay = '1753-01-01'
where ct_ghiso_ngay < '1753-01-01'