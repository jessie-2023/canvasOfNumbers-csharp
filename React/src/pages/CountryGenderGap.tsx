import { useEffect, useState } from "react";
import Gap from "../models/Gap";
import { useParams } from "react-router-dom";

export default function CountryGenderGap()
{
    const { id } = useParams();
    const [countryGaps, setCountryGaps] = useState<Gap[]>([]);

    useEffect(() => {
        fetch(`http://localhost:5287/gender-gap/country/${id}`)
        .then(response => response.json())
        .then(data => setCountryGaps(data))
    }, [id]);

    return (
        <div>
            <h3>Gender gap</h3>
            
            {countryGaps.length > 0 && ((<table className="table">
                <thead>
                    <tr>
                        <th scope="col">Year</th>
                        <th scope="col">Country</th>
                        <th scope="col">Region</th>
                        <th scope="col">General Gap</th>
                        <th scope="col">Health</th>
                        <th scope="col">Education</th>
                        <th scope="col">Economy</th>
                        <th scope="col">Politics</th>
                        <th scope="col">GDPperCap</th>
                        <th scope="col">Population</th>
                    </tr>
                </thead>
                <tbody>
                    {countryGaps.map(gap => <tr>
                        <th scope="row">{gap.year}</th>
                        <td>{gap.countryName}</td>
                        <td>{gap.regionName}</td>
                        <td>{gap.generalGap}</td>
                        <td>{gap.healthGap}</td>
                        <td>{gap.educationGap}</td>
                        <td>{gap.economicalGap}</td>
                        <td>{gap.politicalGap}</td>
                        <td>{gap.gdpPerCapita}</td>
                        <td>{gap.population}</td>
                    </tr>)}
                </tbody>
            </table>))}
        </div>
    )

}