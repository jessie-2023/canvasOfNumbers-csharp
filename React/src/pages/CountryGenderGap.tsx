import { useEffect, useState } from "react";
import Gap from "../models/Gap";
import { useParams } from "react-router-dom";
import { Line, getElementAtEvent } from "react-chartjs-2";
import {
  Chart as ChartJS,
  CategoryScale,
  LinearScale,
  LineElement,
  PointElement,
  Point,
  Title,
  Tooltip,
  Legend,
  TooltipItem,
} from "chart.js";
import { useNavigate } from "react-router-dom";
import chroma from "chroma-js";

ChartJS.register(CategoryScale, LinearScale, LineElement, PointElement, Title, Tooltip, Legend);

export default function CountryGenderGap()
{
    const { id } = useParams();
    const [countryGaps, setCountryGaps] = useState<Gap[]>([]);
    const [lineData, setLineData] = useState({
        labels: [],
        datasets: [{
            label: "Gender Gap Over Time",
            data: [],
            borderColor: "rgba(75, 192, 192, 1)",
            backgroundColor: "rgba(75, 192, 192, 0.2)",
            tension: 0.1,
        },]
    })
    const [loading, setLoading] = useState<boolean>(true);
    const [error, setError] = useState<boolean>(false);

    useEffect(() => {
        fetch(`http://localhost:5287/gender-gap/country/${id}`)
        .then(response => response.json())
        .then(data => {
            setCountryGaps(data);

            const colors = chroma.scale("Set3").colors(4);
            const colorsLess = colors.map(color => chroma(color).alpha(0.5).css()); 
            setLineData({
                labels: data.map((item: Gap) => item.year),
                datasets: [{
                        label: "General",
                        data: data.map((item: Gap) => item.generalGap),
                        borderColor: colors[0],
                        backgroundColor: colorsLess[0],
                        tension: 0.1,
                    },
                    {
                        label: "Health and Survival",
                        data: data.map((item: Gap) => item.healthGap),
                        borderColor: colors[1],
                        backgroundColor: colorsLess[1],
                        tension: 0.1,
                    },
                    {
                        label: "Educational Attainment",
                        data: data.map((item: Gap) => item.educationGap),
                        borderColor: colors[2],
                        backgroundColor: colorsLess[2],
                        tension: 0.1,
                    },
                    {
                        label: "Economic Participation and Opportunity",
                        data: data.map((item: Gap) => item.economicalGap),
                        borderColor: colors[3],
                        backgroundColor: colorsLess[3],
                        tension: 0.1,
                    },
                    {
                        label: "Political Empowerment",
                        data: data.map((item: Gap) => item.politicalGap),
                        borderColor: colors[4],
                        backgroundColor: colorsLess[4],
                        tension: 0.1,                
                    },],
            });

            setLoading(false);
        })
        .catch(() => setError(true))
    }, [id]);


    const lineOption = {
        maintainAspectRatio: false,
        responsive:true,
        plugins: {
            title: {
                display: true,
                text: "How much of the gender gap toward full parity has been closed",
            },
        },
    }

    if (loading) return <p>Loading...</p>;
    if (error) return <p>Error loading data.</p>;

    return (
        <div>
            <h3>Gender gap</h3>           
            {countryGaps.length > 0 && ((<>
            <div className="chart-container">
                <Line data = {lineData} options={lineOption} />
            </div>
            </>))}
        </div>
    )

}