puts "Ingrese el número a multiplicar"
number = gets
number = number.to_i
for i in(1..10)
	mul = i * number
	puts "#{number} * #{i} = #{mul}"
end
