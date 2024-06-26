using Mde.OnlineServices.Flags.WebApi.Dtos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapGet("/flags", () =>
{
    return new FlagDto[]
    {
        new FlagDto { CountryName = "Afghanistan", Image="af.png" },
        new FlagDto { CountryName = "Albania", Image="al.png" },
        new FlagDto { CountryName = "Algeria", Image="dz.png" },
        new FlagDto { CountryName = "American Samoa", Image="as.png" },
        new FlagDto { CountryName = "Andorra", Image="ad.png" },
        new FlagDto { CountryName = "Angola", Image="ao.png" },
        new FlagDto { CountryName = "Anguilla", Image="ai.png" },
        new FlagDto { CountryName = "Antarctica", Image="aq.png" },
        new FlagDto { CountryName = "Antigua and Barbuda", Image="ag.png" },
        new FlagDto { CountryName = "Argentina", Image="ar.png" },
        new FlagDto { CountryName = "Armenia", Image="am.png" },
        new FlagDto { CountryName = "Aruba", Image="aw.png" },
        new FlagDto { CountryName = "Australia", Image="au.png" },
        new FlagDto { CountryName = "Austria", Image="at.png" },
        new FlagDto { CountryName = "Azerbaijan", Image="az.png" },
        new FlagDto { CountryName = "Bahamas (the)", Image="bs.png" },
        new FlagDto { CountryName = "Bahrain", Image="bh.png" },
        new FlagDto { CountryName = "Bangladesh", Image="bd.png" },
        new FlagDto { CountryName = "Barbados", Image="bb.png" },
        new FlagDto { CountryName = "Belarus", Image="by.png" },
        new FlagDto { CountryName = "Belgium", Image="be.png" },
        new FlagDto { CountryName = "Belize", Image="bz.png" },
        new FlagDto { CountryName = "Benin", Image="bj.png" },
        new FlagDto { CountryName = "Bermuda", Image="bm.png" },
        new FlagDto { CountryName = "Bhutan", Image="bt.png" },
        new FlagDto { CountryName = "Bolivia (Plurinational State of)", Image="bo.png" },
        new FlagDto { CountryName = "Bonaire, Sint Eustatius and Saba", Image="bq.png" },
        new FlagDto { CountryName = "Bosnia and Herzegovina", Image="ba.png" },
        new FlagDto { CountryName = "Botswana", Image="bw.png" },
        new FlagDto { CountryName = "Bouvet Island", Image="bv.png" },
        new FlagDto { CountryName = "Brazil", Image="br.png" },
        new FlagDto { CountryName = "British Indian Ocean Territory (the)", Image="io.png" },
        new FlagDto { CountryName = "Brunei Darussalam", Image="bn.png" },
        new FlagDto { CountryName = "Bulgaria", Image="bg.png" },
        new FlagDto { CountryName = "Burkina Faso", Image="bf.png" },
        new FlagDto { CountryName = "Burundi", Image="bi.png" },
        new FlagDto { CountryName = "Cabo Verde", Image="cv.png" },
        new FlagDto { CountryName = "Cambodia", Image="kh.png" },
        new FlagDto { CountryName = "Cameroon", Image="cm.png" },
        new FlagDto { CountryName = "Canada", Image="ca.png" },
        new FlagDto { CountryName = "Cayman Islands (the)", Image="ky.png" },
        new FlagDto { CountryName = "Central African Republic (the)", Image="cf.png" },
        new FlagDto { CountryName = "Chad", Image="td.png" },
        new FlagDto { CountryName = "Chile", Image="cl.png" },
        new FlagDto { CountryName = "China", Image="cn.png" },
        new FlagDto { CountryName = "Christmas Island", Image="cx.png" },
        new FlagDto { CountryName = "Cocos (Keeling) Islands (the)", Image="cc.png" },
        new FlagDto { CountryName = "Colombia", Image="co.png" },
        new FlagDto { CountryName = "Comoros (the)", Image="km.png" },
        new FlagDto { CountryName = "Congo (the Democratic Republic of the)", Image="cd.png" },
        new FlagDto { CountryName = "Congo (the)", Image="cg.png" },
        new FlagDto { CountryName = "Cook Islands (the)", Image="ck.png" },
        new FlagDto { CountryName = "Costa Rica", Image="cr.png" },
        new FlagDto { CountryName = "Croatia", Image="hr.png" },
        new FlagDto { CountryName = "Cuba", Image="cu.png" },
        new FlagDto { CountryName = "Cura�ao", Image="cw.png" },
        new FlagDto { CountryName = "Cyprus", Image="cy.png" },
        new FlagDto { CountryName = "Czechia", Image="cz.png" },
        new FlagDto { CountryName = "C�te d'Ivoire", Image="ci.png" },
        new FlagDto { CountryName = "Denmark", Image="dk.png" },
        new FlagDto { CountryName = "Djibouti", Image="dj.png" },
        new FlagDto { CountryName = "Dominica", Image="dm.png" },
        new FlagDto { CountryName = "Dominican Republic (the)", Image="do.png" },
        new FlagDto { CountryName = "Ecuador", Image="ec.png" },
        new FlagDto { CountryName = "Egypt", Image="eg.png" },
        new FlagDto { CountryName = "El Salvador", Image="sv.png" },
        new FlagDto { CountryName = "Equatorial Guinea", Image="gq.png" },
        new FlagDto { CountryName = "Eritrea", Image="er.png" },
        new FlagDto { CountryName = "Estonia", Image="ee.png" },
        new FlagDto { CountryName = "Eswatini", Image="sz.png" },
        new FlagDto { CountryName = "Ethiopia", Image="et.png" },
        new FlagDto { CountryName = "Falkland Islands (the) [Malvinas]", Image="fk.png" },
        new FlagDto { CountryName = "Faroe Islands (the)", Image="fo.png" },
        new FlagDto { CountryName = "Fiji", Image="fj.png" },
        new FlagDto { CountryName = "Finland", Image="fi.png" },
        new FlagDto { CountryName = "France", Image="fr.png" },
        new FlagDto { CountryName = "French Guiana", Image="gf.png" },
        new FlagDto { CountryName = "French Polynesia", Image="pf.png" },
        new FlagDto { CountryName = "French Southern Territories (the)", Image="tf.png" },
        new FlagDto { CountryName = "Gabon", Image="ga.png" },
        new FlagDto { CountryName = "Gambia (the)", Image="gm.png" },
        new FlagDto { CountryName = "Georgia", Image="ge.png" },
        new FlagDto { CountryName = "Germany", Image="de.png" },
        new FlagDto { CountryName = "Ghana", Image="gh.png" },
        new FlagDto { CountryName = "Gibraltar", Image="gi.png" },
        new FlagDto { CountryName = "Greece", Image="gr.png" },
        new FlagDto { CountryName = "Greenland", Image="gl.png" },
        new FlagDto { CountryName = "Grenada", Image="gd.png" },
        new FlagDto { CountryName = "Guadeloupe", Image="gp.png" },
        new FlagDto { CountryName = "Guam", Image="gu.png" },
        new FlagDto { CountryName = "Guatemala", Image="gt.png" },
        new FlagDto { CountryName = "Guernsey", Image="gg.png" },
        new FlagDto { CountryName = "Guinea", Image="gn.png" },
        new FlagDto { CountryName = "Guinea-Bissau", Image="gw.png" },
        new FlagDto { CountryName = "Guyana", Image="gy.png" },
        new FlagDto { CountryName = "Haiti", Image="ht.png" },
        new FlagDto { CountryName = "Heard Island and McDonald Islands", Image="hm.png" },
        new FlagDto { CountryName = "Holy See (the)", Image="va.png" },
        new FlagDto { CountryName = "Honduras", Image="hn.png" },
        new FlagDto { CountryName = "Hong Kong", Image="hk.png" },
        new FlagDto { CountryName = "Hungary", Image="hu.png" },
        new FlagDto { CountryName = "Iceland", Image="is.png" },
        new FlagDto { CountryName = "India", Image="in.png" },
        new FlagDto { CountryName = "Indonesia", Image="id.png" },
        new FlagDto { CountryName = "Iran (Islamic Republic of)", Image="ir.png" },
        new FlagDto { CountryName = "Iraq", Image="iq.png" },
        new FlagDto { CountryName = "Ireland", Image="ie.png" },
        new FlagDto { CountryName = "Isle of Man", Image="im.png" },
        new FlagDto { CountryName = "Israel", Image="il.png" },
        new FlagDto { CountryName = "Italy", Image="it.png" },
        new FlagDto { CountryName = "Jamaica", Image="jm.png" },
        new FlagDto { CountryName = "Japan", Image="jp.png" },
        new FlagDto { CountryName = "Jersey", Image="je.png" },
        new FlagDto { CountryName = "Jordan", Image="jo.png" },
        new FlagDto { CountryName = "Kazakhstan", Image="kz.png" },
        new FlagDto { CountryName = "Kenya", Image="ke.png" },
        new FlagDto { CountryName = "Kiribati", Image="ki.png" },
        new FlagDto { CountryName = "Korea (the Democratic People's Republic of)", Image="kp.png" },
        new FlagDto { CountryName = "Korea (the Republic of)", Image="kr.png" },
        new FlagDto { CountryName = "Kuwait", Image="kw.png" },
        new FlagDto { CountryName = "Kyrgyzstan", Image="kg.png" },
        new FlagDto { CountryName = "Lao People's Democratic Republic (the)", Image="la.png" },
        new FlagDto { CountryName = "Latvia", Image="lv.png" },
        new FlagDto { CountryName = "Lebanon", Image="lb.png" },
        new FlagDto { CountryName = "Lesotho", Image="ls.png" },
        new FlagDto { CountryName = "Liberia", Image="lr.png" },
        new FlagDto { CountryName = "Libya", Image="ly.png" },
        new FlagDto { CountryName = "Liechtenstein", Image="li.png" },
        new FlagDto { CountryName = "Lithuania", Image="lt.png" },
        new FlagDto { CountryName = "Luxembourg", Image="lu.png" },
        new FlagDto { CountryName = "Macao", Image="mo.png" },
        new FlagDto { CountryName = "Madagascar", Image="mg.png" },
        new FlagDto { CountryName = "Malawi", Image="mw.png" },
        new FlagDto { CountryName = "Malaysia", Image="my.png" },
        new FlagDto { CountryName = "Maldives", Image="mv.png" },
        new FlagDto { CountryName = "Mali", Image="ml.png" },
        new FlagDto { CountryName = "Malta", Image="mt.png" },
        new FlagDto { CountryName = "Marshall Islands (the)", Image="mh.png" },
        new FlagDto { CountryName = "Martinique", Image="mq.png" },
        new FlagDto { CountryName = "Mauritania", Image="mr.png" },
        new FlagDto { CountryName = "Mauritius", Image="mu.png" },
        new FlagDto { CountryName = "Mayotte", Image="yt.png" },
        new FlagDto { CountryName = "Mexico", Image="mx.png" },
        new FlagDto { CountryName = "Micronesia (Federated States of)", Image="fm.png" },
        new FlagDto { CountryName = "Moldova (the Republic of)", Image="md.png" },
        new FlagDto { CountryName = "Monaco", Image="mc.png" },
        new FlagDto { CountryName = "Mongolia", Image="mn.png" },
        new FlagDto { CountryName = "Montenegro", Image="me.png" },
        new FlagDto { CountryName = "Montserrat", Image="ms.png" },
        new FlagDto { CountryName = "Morocco", Image="ma.png" },
        new FlagDto { CountryName = "Mozambique", Image="mz.png" },
        new FlagDto { CountryName = "Myanmar", Image="mm.png" },
        new FlagDto { CountryName = "Namibia", Image="na.png" },
        new FlagDto { CountryName = "Nauru", Image="nr.png" },
        new FlagDto { CountryName = "Nepal", Image="np.png" },
        new FlagDto { CountryName = "Netherlands (the)", Image="nl.png" },
        new FlagDto { CountryName = "New Caledonia", Image="nc.png" },
        new FlagDto { CountryName = "New Zealand", Image="nz.png" },
        new FlagDto { CountryName = "Nicaragua", Image="ni.png" },
        new FlagDto { CountryName = "Niger (the)", Image="ne.png" },
        new FlagDto { CountryName = "Nigeria", Image="ng.png" },
        new FlagDto { CountryName = "Niue", Image="nu.png" },
        new FlagDto { CountryName = "Norfolk Island", Image="nf.png" },
        new FlagDto { CountryName = "Northern Mariana Islands (the)", Image="mp.png" },
        new FlagDto { CountryName = "Norway", Image="no.png" },
        new FlagDto { CountryName = "Oman", Image="om.png" },
        new FlagDto { CountryName = "Pakistan", Image="pk.png" },
        new FlagDto { CountryName = "Palau", Image="pw.png" },
        new FlagDto { CountryName = "Palestine, State of", Image="ps.png" },
        new FlagDto { CountryName = "Panama", Image="pa.png" },
        new FlagDto { CountryName = "Papua New Guinea", Image="pg.png" },
        new FlagDto { CountryName = "Paraguay", Image="py.png" },
        new FlagDto { CountryName = "Peru", Image="pe.png" },
        new FlagDto { CountryName = "Philippines (the)", Image="ph.png" },
        new FlagDto { CountryName = "Pitcairn", Image="pn.png" },
        new FlagDto { CountryName = "Poland", Image="pl.png" },
        new FlagDto { CountryName = "Portugal", Image="pt.png" },
        new FlagDto { CountryName = "Puerto Rico", Image="pr.png" },
        new FlagDto { CountryName = "Qatar", Image="qa.png" },
        new FlagDto { CountryName = "Republic of North Macedonia", Image="mk.png" },
        new FlagDto { CountryName = "Romania", Image="ro.png" },
        new FlagDto { CountryName = "Russian Federation (the)", Image="ru.png" },
        new FlagDto { CountryName = "Rwanda", Image="rw.png" },
        new FlagDto { CountryName = "R�union", Image="re.png" },
        new FlagDto { CountryName = "Saint Barth�lemy", Image="bl.png" },
        new FlagDto { CountryName = "Saint Helena, Ascension and Tristan da Cunha", Image="sh.png" },
        new FlagDto { CountryName = "Saint Kitts and Nevis", Image="kn.png" },
        new FlagDto { CountryName = "Saint Lucia", Image="lc.png" },
        new FlagDto { CountryName = "Saint Martin (French part)", Image="mf.png" },
        new FlagDto { CountryName = "Saint Pierre and Miquelon", Image="pm.png" },
        new FlagDto { CountryName = "Saint Vincent and the Grenadines", Image="vc.png" },
        new FlagDto { CountryName = "Samoa", Image="ws.png" },
        new FlagDto { CountryName = "San Marino", Image="sm.png" },
        new FlagDto { CountryName = "Sao Tome and Principe", Image="st.png" },
        new FlagDto { CountryName = "Saudi Arabia", Image="sa.png" },
        new FlagDto { CountryName = "Senegal", Image="sn.png" },
        new FlagDto { CountryName = "Serbia", Image="rs.png" },
        new FlagDto { CountryName = "Seychelles", Image="sc.png" },
        new FlagDto { CountryName = "Sierra Leone", Image="sl.png" },
        new FlagDto { CountryName = "Singapore", Image="sg.png" },
        new FlagDto { CountryName = "Sint Maarten (Dutch part)", Image="sx.png" },
        new FlagDto { CountryName = "Slovakia", Image="sk.png" },
        new FlagDto { CountryName = "Slovenia", Image="si.png" },
        new FlagDto { CountryName = "Solomon Islands", Image="sb.png" },
        new FlagDto { CountryName = "Somalia", Image="so.png" },
        new FlagDto { CountryName = "South Africa", Image="za.png" },
        new FlagDto { CountryName = "South Georgia and the South Sandwich Islands", Image="gs.png" },
        new FlagDto { CountryName = "South Sudan", Image="ss.png" },
        new FlagDto { CountryName = "Spain", Image="es.png" },
        new FlagDto { CountryName = "Sri Lanka", Image="lk.png" },
        new FlagDto { CountryName = "Sudan (the)", Image="sd.png" },
        new FlagDto { CountryName = "Suriname", Image="sr.png" },
        new FlagDto { CountryName = "Svalbard and Jan Mayen", Image="sj.png" },
        new FlagDto { CountryName = "Sweden", Image="se.png" },
        new FlagDto { CountryName = "Switzerland", Image="ch.png" },
        new FlagDto { CountryName = "Syrian Arab Republic", Image="sy.png" },
        new FlagDto { CountryName = "Taiwan (Province of China)", Image="tw.png" },
        new FlagDto { CountryName = "Tajikistan", Image="tj.png" },
        new FlagDto { CountryName = "Tanzania, United Republic of", Image="tz.png" },
        new FlagDto { CountryName = "Thailand", Image="th.png" },
        new FlagDto { CountryName = "Timor-Leste", Image="tl.png" },
        new FlagDto { CountryName = "Togo", Image="tg.png" },
        new FlagDto { CountryName = "Tokelau", Image="tk.png" },
        new FlagDto { CountryName = "Tonga", Image="to.png" },
        new FlagDto { CountryName = "Trinidad and Tobago", Image="tt.png" },
        new FlagDto { CountryName = "Tunisia", Image="tn.png" },
        new FlagDto { CountryName = "Turkey", Image="tr.png" },
        new FlagDto { CountryName = "Turkmenistan", Image="tm.png" },
        new FlagDto { CountryName = "Turks and Caicos Islands (the)", Image="tc.png" },
        new FlagDto { CountryName = "Tuvalu", Image="tv.png" },
        new FlagDto { CountryName = "Uganda", Image="ug.png" },
        new FlagDto { CountryName = "Ukraine", Image="ua.png" },
        new FlagDto { CountryName = "United Arab Emirates (the)", Image="ae.png" },
        new FlagDto { CountryName = "United Kingdom of Great Britain and Northern Ireland (the)", Image="gb.png" },
        new FlagDto { CountryName = "United States Minor Outlying Islands (the)", Image="um.png" },
        new FlagDto { CountryName = "United States of America (the)", Image="us.png" },
        new FlagDto { CountryName = "Uruguay", Image="uy.png" },
        new FlagDto { CountryName = "Uzbekistan", Image="uz.png" },
        new FlagDto { CountryName = "Vanuatu", Image="vu.png" },
        new FlagDto { CountryName = "Venezuela (Bolivarian Republic of)", Image="ve.png" },
        new FlagDto { CountryName = "Viet Nam", Image="vn.png" },
        new FlagDto { CountryName = "Virgin Islands (British)", Image="vg.png" },
        new FlagDto { CountryName = "Virgin Islands (U.S.)", Image="vi.png" },
        new FlagDto { CountryName = "Wallis and Futuna", Image="wf.png" },
        new FlagDto { CountryName = "Western Sahara", Image="eh.png" },
        new FlagDto { CountryName = "Yemen", Image="ye.png" },
        new FlagDto { CountryName = "Zambia", Image="zm.png" },
        new FlagDto { CountryName = "Zimbabwe", Image="zw.png" },
        new FlagDto { CountryName = "�land Islands", Image="ax.png" }
    };
})
.WithOpenApi();

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
