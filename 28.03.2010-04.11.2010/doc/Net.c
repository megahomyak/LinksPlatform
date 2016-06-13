struct Link
{
	Link* Source;
	Link* Verb;
	Link* Target;
	
	Link* NextSourceLink;
	Link* NextVerbLink;
	Link* NextTargetLink;
}

[is] = (is is is)
[04] (04) (04) (04) (04) (10) (04)

[x] = (x is x)
[10] (10) (04) (10) (11) (11) (10)

(x is y)
[11] (10) (04) (09) (12) (12) (09)

(x is z)
[12] (10) (04) (17) (10) (09) (17)

(y is y)
[09] (09) (04) (09) (09) (17) (11)

(z is z)
[17] (17) (04) (17) (17) (04) (12)



Person is a customer of Legal Entity





необходимо из каждой конкретной связи (Link) получать доступ ко всем связям, где этот (Link) является либо Sourc`ом, либо Target`ом, и даже лучше ещё и Verb`ом
She is a doctor.
She - source
is - verb
doctor - target

(She is (18 years old)) - ещё два линка
She - само по себе тоже линк - (She is She)

из линка (She is She) нужно получить доступ к линкам о профессии и возрасте
как это лучше сделать?


понятно что - [7] (7) (3) (7)
где [] - физический адрес самого Link`а
() - значения, соответственно: source, verb, target
основная её фича в том, что всё есть Link
и в памяти будут только линки, а это значит что память будет разбита всегда на равные блоки и никаких проблем с управлением этой памятью, дефрагментацией и т.п. не будет
и вопрос в том, добавлять ли ещё какие-то поля в структуру
